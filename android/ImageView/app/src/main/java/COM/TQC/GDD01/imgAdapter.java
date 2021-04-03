package COM.TQC.GDD01;

import android.content.Context;
import android.support.annotation.NonNull;
import android.support.annotation.Nullable;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;

import java.util.ArrayList;

public class imgAdapter extends ArrayAdapter<Integer> {

    private  Context mContext;
    private  int mResouce;
    public imgAdapter(@NonNull Context context, int resource, @NonNull ArrayList objects) {
        super(context, resource, objects);
        mContext =context;
        mResouce =resource;
    }
    @Override
    public View getView(int position, @Nullable View convertView, @NonNull ViewGroup parent) {

        LayoutInflater inflater = LayoutInflater.from(mContext);
        convertView = inflater.inflate(mResouce,parent,false);

        ImageView imageView = convertView.findViewById(R.id.image);
        imageView.setImageResource(getItem(position));
        return  convertView;
    }
}
